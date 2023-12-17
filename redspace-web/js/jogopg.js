$(document).ready(function () {
    // Verifica se o usuário está logado
    if (Cookies.get('token-idusuario') == null) {
        window.location.href = 'loginpg.html'
    }
    var urlParams = new URLSearchParams(window.location.search);
    var idSelecionado = urlParams.get('idJogo');

    // Tráz informações do jogo
    $.ajax({
        url: 'http://localhost:5064/api/Jogo/' + idSelecionado,
        type: 'get',
        contentType: 'application/json',
        success: function (dados) {
            var menuJogo = $('.bannerPrincipal');
            var description = $('.right-description')
            var infoJogo = '';
            infoJogo += '<img class="img containerGaleria" src="' + dados.banner + '" alt=""></img>'

            // Tráz a galeria
            $.ajax({
                url: 'http://localhost:5064/api/Galeria/' + idSelecionado,
                type: 'get',
                headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                contentType: 'application/json',
                success: function (dadosGaleria) {
                    var galeriaContainer = $('.bannerPrincipal');
                    var galeria = '';
                    galeria += '<br><br><div class="gallery-container">'
                    dadosGaleria.forEach(function (item) {
                        galeria += '<div class="small-img-col">'
                        galeria += '<a href="' + item.fotoPath + '" data-lightbox="img-game"><img src="' + item.fotoPath + '" width="100%" class="small-img" alt="game-img"></a>'
                        galeria += '</div>'
                    })
                    galeria += '</div>'
                    galeriaContainer.append(galeria)
                },
                error: function (erro) {
                    console.log(erro)
                }
            })
            menuJogo.append(infoJogo);
            $('#btnDownload').attr('href', dados.instaladorPath);
            infoJogo = '';
            infoJogo += '<ul>'
            infoJogo += '<h2>' + dados.nome + '</h2>'
            infoJogo += '<p>' + dados.descricao + '</p><br><br>'
            infoJogo += '<p> Desenvolvido por: ' + dados.idDesenvolvedor + '</p>'
            infoJogo += '</ul>'
            description.append(infoJogo);

            // Tráz os comentários do jogo
            $.ajax({
                url: 'http://localhost:5064/api/Comentario/' + idSelecionado,
                type: 'get',
                headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                contentType: 'application/json',
                success: function (dados) {
                    var classificacaoContainer = $('.classificacao-api');
                    var estrelas = '';
                    var totalNotas = 0;
                    var totalReviews = 0;
                    dados.forEach(function (item) {
                        totalNotas += item.nota;
                        totalReviews++;
                    });
                    var media = Math.floor(totalNotas / totalReviews);
                    var x = 0;
                    while (x < media) {
                        estrelas += '<i class="bx bxs-star"></i>'
                        x++;
                    }
                    classificacaoContainer.append(estrelas);
                },
                error: function (erro) {
                    console.log(erro);
                }
            });
        },
        error: function (erro) {
            console.log(erro)
        }
    })

    // Cadastra o jogo no histórico do usuário
    $('#btnDownload').click(function () {
        var idUsuario = Cookies.get('token-idusuario')
        $.ajax({
            url: 'http://localhost:5064/api/UsuarioJogo/api/UsuarioJogo/verificajogo?IdUsuario=' + idUsuario + '&IdJogo=' + idSelecionado,
            type: 'get',
            headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
            contentType: 'application/json',
            success: function (mensagem) {
                if (mensagem == 'false') {
                    var usuariojogo = new Object;
                    usuariojogo.idUsuario = idUsuario;
                    usuariojogo.idJogo = idSelecionado;
                    $.ajax({
                        url: 'http://localhost:5064/api/UsuarioJogo',
                        type: 'post',
                        headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                        contentType: 'application/json',
                        data: JSON.stringify(usuariojogo),
                        success: function (dados) {
                            console.log('historico criado')
                        },
                        error: function (erro) {
                            console.log(erro);
                        }
                    });
                }
            },
            error: function (erro) {
                console.log(erro);
            }
        });
    })

    // Tráz os comentários do jogo
    $.ajax({
        url: 'http://localhost:5064/api/Comentario/' + idSelecionado,
        type: 'get',
        headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
        contentType: 'application/json',
        success: function (dados) {
            var containerComentarios = $('.comentariosContainer');
            var comentariosHTML = '';
            dados.reverse();
            dados.forEach(function (item) {
                var comentario = '<div class="darker">';
                comentario += '<img src="./img/login/user-profile-picture.png" alt="" class="rounded-circle" width="40" height="40">';
                comentario += '<h4>   ' + item.idUsuario + '</h4><br>';
                const data = new Date(item.data)
                comentario += '<br><h4>   ' + data.toLocaleDateString() + '</h4><br><br>';
                var x = 1;
                while (x <= item.nota) {
                    comentario += '<i class="bx bxs-star" style="color: yellow;"></i>'
                    x++;
                }
                comentario += '<br><p>' + item.comentario + '</p>';
                comentario += '</div>';
                comentariosHTML += comentario;
            });
            containerComentarios.empty().append(comentariosHTML);
        },
        error: function (erro) {
            console.log(erro);
        }
    });

    // Cadastra o comentário
    $("#postComentario").click(function () {
        var selectedRating = $("input[name='rating']:checked");
        if (selectedRating.length > 0) {
            var ratingValue = selectedRating.val();
            var comentario = $('#txtComentario').val();
            if (comentario == '') {
                $('#erroModal').modal('show');
                return;
            }
            var objComentario = new Object;
            objComentario.idUsuario = Cookies.get('token-idusuario');
            objComentario.idJogo = idSelecionado;
            objComentario.comentario = comentario;
            objComentario.nota = ratingValue;
            $.ajax({
                url: 'http://localhost:5064/api/Comentario',
                type: 'post',
                headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                contentType: 'application/json',
                data: JSON.stringify(objComentario),
                success: function (dados) {
                    $('#comentarioModal').modal('show');
                    $('#txtComentario').val('');
                    $.ajax({
                        url: 'http://localhost:5064/api/Comentario/' + idSelecionado,
                        type: 'get',
                        headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                        contentType: 'application/json',
                        success: function (dados) {
                            var containerComentarios = $('.comentariosContainer');
                            var comentariosHTML = '';
                            dados.reverse();
                            dados.forEach(function (item) {
                                var comentario = '<div class="darker">';
                                comentario += '<img src="./img/login/user-profile-picture.png" alt="" class="rounded-circle" width="40" height="40">';
                                comentario += '<h4>   ' + item.idUsuario + '</h4><br>';
                                const data = new Date(item.data)
                                comentario += '<br><h4>   ' + data.toLocaleDateString() + '</h4><br><br>';
                                var x = 1;
                                while (x <= item.nota) {
                                    comentario += '<i class="bx bxs-star" style="color: yellow;"></i>'
                                    x++;
                                }
                                comentario += '<br><p>' + item.comentario + '</p>';
                                comentario += '</div>';
                                comentariosHTML += comentario;
                            });
                            containerComentarios.empty().append(comentariosHTML);
                        },
                        error: function (erro) {
                            console.log(erro);
                        }
                    });
                    $('.classificacao-api').find('.manter').nextAll().remove();
                    $.ajax({
                        url: 'http://localhost:5064/api/Comentario/' + idSelecionado,
                        type: 'get',
                        headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
                        contentType: 'application/json',
                        success: function (dados) {
                            var classificacaoContainer = $('.classificacao-api');
                            var estrelas = '';
                            var totalNotas = 0;
                            var totalReviews = 0;
                            dados.forEach(function (item) {
                                totalNotas += item.nota;
                                totalReviews++;
                            });
                            var media = Math.floor(totalNotas / totalReviews);
                            var x = 0;
                            while (x < media) {
                                estrelas += '<i class="bx bxs-star"></i>'
                                x++;
                            }
                            classificacaoContainer.append(estrelas);
                        },
                        error: function (erro) {
                            console.log(erro);
                        }
                    });
                },
                error: function (erro) {
                    console.log(erro);
                }
            })
        } else {
            console.log("Nenhuma estrela selecionada.");
        }
    });
})

// Deslogar
$('.sair').click(function () {
    var expirationDate = new Date(0);
    Cookies.set('token-login', '', { expires: expirationDate });
    Cookies.set('token-nome', '', { expires: expirationDate });
    Cookies.set('token-idusuario', '', { expires: expirationDate });
    window.location.reload();
})


// Fechamento dos modals
$('#btnFecharModal').click(function () {
    $('#comentarioModal').modal('hide');
})

$('#btnFecharModalErro').click(function () {
    $('#erroModal').modal('hide');
})



