$(document).ready(function () {
    // Logar
    $('#btnLogin').click(function () {
        var email = $('#txtEmail').val();
        var senha = $('#txtSenha').val();
        var erro;
        $(".modal-body").empty();
        var textoModal = $('.modal-body');
        if (email.trim() == "" || senha.trim() == "") {
            erro = '<p>Preencha ambos os campos!</p>'
            textoModal.append(erro);
            $('#loginModal').modal('show');
            return;
        }
        else {
            var login = new Object;
            login.username = email;
            login.password = senha;
        }
        $.ajax({
            url: 'http://localhost:5064/api/Authentication/login',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(login),
            success: function (dados) {
                Cookies.set('token-login', dados.token)
                Cookies.set('token-nome', dados.nomeUsuario)
                Cookies.set('token-idusuario', dados.idUsuario)
                window.location.href = 'index.html'
            },
            error: function (erro) {
                if (erro.status == 401) {
                    console.log(erro);
                }
                else {
                    console.log(erro);
                }
                erro = '<p>Usuário ou senha inválidos. Tente novamente!</p>';
                textoModal.append(erro);
                $('#loginModal').modal('show');
            }
        })
    });
});

// Fechamento do modal
$('#btnFecharModal').click(function () {
    $('#loginModal').modal('hide');
})
