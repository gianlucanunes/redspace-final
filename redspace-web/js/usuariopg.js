$(document).ready(function () {
    // Tráz informações do usuário
    $.ajax({
        url: "http://localhost:5064/api/UsuarioJogo/" + Cookies.get('token-idusuario'),
        type: "get",
        headers: { 'Authorization': 'Bearer ' + Cookies.get('token-login') },
        contentType: 'application/json',
        success: function (dados) {
            var txtNome = $('.line');
            var nome = '';
            nome = '<h3>' + Cookies.get('token-nome') + '</h3>'
            txtNome.append(nome)
            dados.forEach(function (item) {
                // Tráz o histórico do usuário
                $.ajax({
                    url: "http://localhost:5064/api/Jogo/" + item.idJogo,
                    type: "get",
                    contentType: 'application/json',
                    success: function (dadosJogo) {
                        var jogos = $('.photos');
                        var jogo = '';
                        jogo += '<a href="jogopg.html?idJogo=' + dadosJogo.idJogo + '"><img src="' + dadosJogo.banner + '" alt="Photo"/></a>'
                        jogos.append(jogo);
                    },
                    error: function (erro) {
                        console.log(erro);
                    }
                })
            })
        },
        error: function (erro) {
            if (erro.status == 401) {
                window.location.href = 'loginpg.html'
            }
            else {
                alert('Erro ao fazer o login.');
                console.log(erro);
            }
        }
    })
})

// Deslogar
$('.sair').click(function () {
    var expirationDate = new Date(0);
    Cookies.set('token-login', '', { expires: expirationDate });
    Cookies.set('token-nome', '', { expires: expirationDate });
    Cookies.set('token-idusuario', '', { expires: expirationDate });
    window.location.reload();
})