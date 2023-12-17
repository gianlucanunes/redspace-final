// Cadastro de usuário
$('#btnCadastrar').click(function () {
    var nome = $('#txtNome').val()
    var email = $('#txtEmail').val()
    var senha = $('#txtSenha').val()
    $(".modal-body").empty();
    var mensagem = '';
    var modalBody = $('.modal-body');
    var verificaSenha = $('#txtVerificaSenha').val()
    if (nome == '' || email == '' || senha == '' || verificaSenha == '') {
        mensagem = '<p>Todos os campos devem ser preenchidos.</p>'
        modalBody.append(mensagem);
        $('#registerErroModal').modal('show');
        return
    }
    else if (senha != verificaSenha) {
        mensagem = '<p>As senhas não batem.</p>'
        modalBody.append(mensagem);
        $('#registerErroModal').modal('show');
        return
    }
    else if (!$('#checkTermos').prop('checked')) {
        mensagem = '<p>Você deve ler e concordar com os termos antes de continuar.</p>'
        modalBody.append(mensagem);
        $('#registerErroModal').modal('show');
        return;
    }
    else {
        var usuario = new Object;
        usuario.nome = nome;
        usuario.senha = senha;
        usuario.email = email;
        $.ajax({
            url: 'http://localhost:5064/api/Usuario',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(usuario),
            success: function (dados) {
                mensagem = '<p>Agora, faça o login para desfrutar da plataforma!</p>'
                modalBody.append(mensagem);
                $('#registerModal').modal('show');
            },
            error: function (erro) {
                if (erro.status == 400) {
                    mensagem = '<p>O e-mail utilizado já está cadastrado.</p>'
                    modalBody.append(mensagem);
                    $('#registerErroModal').modal('show');
                }
                else {
                    console.log(erro);
                }
            }
        })
    }
});

// Fechamento dos modals
$('#btnFecharModal').click(function () {
    $('#registerErroModal').modal('hide');
})

$('#btnFecharModalSucesso').click(function () {
    window.location.href = 'loginpg.html'
})
