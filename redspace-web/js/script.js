
// Inicia AOS
AOS.init({
  duration: 2000,
});

// Sidebar Catálogo
var elementosMenu = document.getElementsByClassName("sidebar-menu");
var contador = 0;
function alternarClasse() {
  var mainMenuElement = document.querySelector('.main-menu');
  if (contador % 2 === 0) {
    mainMenuElement.classList.add("active");
    setTimeout(function () {
      document.querySelector('.sidebar-itens').classList.add('show');
    }, 1000);
  } else {
    mainMenuElement.classList.remove("active");
    document.querySelector('.sidebar-itens').classList.remove('show');
  }
  contador++;
}
for (var i = 0; i < elementosMenu.length; i++) {
  elementosMenu[i].addEventListener("click", alternarClasse);
}

// Swiper catalogo
var swiper = new Swiper(".catalogoSwiper", {
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});
for (var i = 0; i < elementosMenu.length; i++) {
  elementosMenu[i].addEventListener("click", alternarClasse);
}

// Scroll to top
var mybutton = document.getElementById("myBtn");
window.onscroll = function () { scrollFunction() };
function scrollFunction() {
  if (document.body.scrollTop > 650 || document.documentElement.scrollTop > 650) {
    mybutton.style.display = "block";
  } else {
    mybutton.style.display = "none";
  }
}
function topFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

$(document).ready(function () {
  var swiper = new Swiper(".catalogoSwiper", {
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev",
    },
  });
  var navbarLogin = $('.login-area');
  var conteudoLogin = '';

  // Verifica se o usuário está logado
  if (Cookies.get('token-idusuario') == null) {
    navbarLogin.empty();
    conteudoLogin += '<button type="button" id="btnEntrar" class="btnLogin"><h2>Entrar</h2></button>'
    conteudoLogin += '<button type="button" id="btnCadastrar" class="btnLogin"><h2>Cadastrar</h2></button>'
    navbarLogin.append(conteudoLogin);
  }
  else {
    navbarLogin.empty();
    conteudoLogin += '<li class="dropright">'
    conteudoLogin += '<a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">'
    conteudoLogin += '<i style="height: 15%;"class="bx bx-user-circle"></i>'
    conteudoLogin += '</a>'
    conteudoLogin += '<ul class="dropdown-menu dropdown-menu-end my-profile-dropdown">'
    conteudoLogin += '<li><a class="dropdown-item" href="usuariopg.html">Meu perfil</a>'
    conteudoLogin += '</li>'
    conteudoLogin += '<li>'
    conteudoLogin += '<hr>'
    conteudoLogin += '</li>'
    conteudoLogin += '<li><a href="#" class="dropdown-item sair">Sair</a></li>'
    conteudoLogin += '</ul>'
    conteudoLogin += '</li>'
    navbarLogin.append(conteudoLogin);
  }
  $('#btnEntrar').click(function () {
    window.location.href = 'loginpg.html';
  })
  $('#btnCadastrar').click(function () {
    window.location.href = 'registerpg.html';
  })
  $('.sair').click(function () {
    var expirationDate = new Date(0);
    Cookies.set('token-login', '', { expires: expirationDate });
    Cookies.set('token-nome', '', { expires: expirationDate });
    Cookies.set('token-idusuario', '', { expires: expirationDate });
    window.location.reload();
  })

  // Carrega Jogos Recém Lançados
  $.ajax({
    url: "http://localhost:5064/api/Jogo/listajogosrecemlancados",
    type: "get",
    contentType: 'application/json',
    success: function (dados) {
      var recemLancados = $('.cards-recem-lancados');
      var x = 1;
      dados.forEach(function (item) {
        var jogo = '';
        if (x == 1) {
          jogo += '<div class="col-lg-4 mt-4 mt-lg-0">'
          jogo += '    <div class="member my-card card1">'
          jogo += '        <div class="pic"><img src="' + item.banner + '" class="img-fluid" alt=""></div>'
          jogo += '         <div class="member-info">'
          jogo += '           <h4>' + item.nome + '</h4>'
          jogo += '             <p class="card-subtitle">' + item.idCategoria + '</p>'
          jogo += '            <p><a class="btnLancamentos" href="jogopg.html?idJogo=' + item.idJogo + '">CONFIRA!</a></p>'
          jogo += '         </div>'
          jogo += '     </div>'
          jogo += ' </div>'
          recemLancados.append(jogo);
        }
        else if (x == 2) {
          jogo += '<div class="col-lg-4 mt-4 mt-lg-0">'
          jogo += '<div class="member my-card">'
          jogo += '<div class="pic"><img src="' + item.banner + '" class="img-fluid" alt=""></div>'
          jogo += '<div class="member-info">'
          jogo += '<h4>' + item.nome + '</h4>'
          jogo += '<p class="card-subtitle">' + item.idCategoria + '</p>'
          jogo += '<p><a class="btnLancamentos" href="jogopg.html?idJogo=' + item.idJogo + '">CONFIRA!</a></p>'
          jogo += '</div>'
          jogo += '</div>'
          jogo += '</div>'
          recemLancados.append(jogo);
        }
        else if (x == 3) {
          jogo += '<div class="col-lg-4 mt-4 mt-lg-0">'
          jogo += '<div class="member my-card card3">'
          jogo += '<div class="pic"><img src="' + item.banner + '" class="img-fluid" alt=""></div>'
          jogo += '<div class="member-info">'
          jogo += '<h4>' + item.nome + '</h4>'
          jogo += '<p class="card-subtitle">' + item.idCategoria + '</p>'
          jogo += '<p><a class="btnLancamentos" href="jogopg.html?idJogo=' + item.idJogo + '">CONFIRA!</a></p>'
          jogo += '</div>'
          jogo += '</div>'
          jogo += '</div>'
          recemLancados.append(jogo);
        }
        x++;
      });
    },
    error: function (erro) {
      console.log(erro);
    }
  });

  // Carrega Jogos Destaques
  $.ajax({
    url: "http://localhost:5064/api/Jogo/carregajogosdestaques",
    type: "get",
    contentType: 'application/json',
    success: function (dados) {
      var destaques = $('.jogos-destaques-api');
      dados.forEach(function (item) {
        var jogo = '';
        jogo += '<div class="swiper-slide">'
        jogo += '<img src="' + item.banner + '" alt="">'
        jogo += '<div class="swiper-info">'
        jogo += '<ul>'
        jogo += '<li>'
        jogo += '<h3>' + item.nome + '</h3>'
        jogo += '</li>'
        jogo += '<li>'
        jogo += '<span>' + item.descricao + '</span>'
        jogo += '</li>'
        jogo += '</ul>'
        jogo += '</div>'
        jogo += '<div class="swiper-btn">'
        jogo += '<ul>'
        jogo += '<li class="btn-space">'
        jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '"><input type="button" value="Página do Jogo"></a>'
        jogo += '</li>'
        jogo += '</ul>'
        jogo += '</div>'
        jogo += '</div>'
        destaques.append(jogo);
      });
      // swiper dos jogos destaques
      var swiper = new Swiper(".mySwiper", {
        cssMode: true,
        navigation: {
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        },
        pagination: {
          el: ".swiper-pagination",
        },
        mousewheel: true,
        keyboard: true,
      });
    },
    error: function (erro) {
      console.log(erro);
    }
  });

  // Carrega Jogos Catalogo
  CarregaJogos();
})

// Função para carregar os jogos do catálogo
function CarregaJogos() {
  $.ajax({
    url: "http://localhost:5064/api/Jogo",
    type: "get",
    contentType: 'application/json',
    success: function (dados) {
      var catalogoFinal = $('.catalogo-gallery-api');
      var totalJogos = 0;
      var jogoAtual = 1;
      var fim = false;
      var jogo = '';
      dados.forEach(function (item) {
        totalJogos++;
      });
      dados.forEach(function (item) {
        if (fim == false) {
          if (jogoAtual == 1) {
            jogo += '<div class="swiper-slide">';
            jogo += '<ul class="catalogo-gallery-top grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 1) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 2) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            jogo += '</ul>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 2) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 3) {
            jogo += '<ul class="catalogo-gallery-bottom grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 3) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 4) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          else if (totalJogos != 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            jogoAtual = 0;
          }
          jogoAtual++;
        }
      });
      catalogoFinal.append(jogo);
    },
    error: function (erro) {
      console.log(erro);
    }
  });
}

// Pesquisa jogo por nome no catálogo
$(".botaoPesquisa").click(function () {
  $(".catalogo-gallery-api").empty();
  var nomeJogo = $('#inputPesquisa').val();
  $.ajax({
    url: "http://localhost:5064/api/Jogo/pesquisajogo?nome=" + nomeJogo,
    type: "get",
    contentType: 'application/json',
    success: function (dados) {
      var catalogoFinal = $('.catalogo-gallery-api');
      var totalJogos = 0;
      var jogoAtual = 1;
      var fim = false;
      var jogo = '';
      dados.forEach(function (item) {
        totalJogos++;
      });
      dados.forEach(function (item) {
        if (fim == false) {
          if (jogoAtual == 1) {
            jogo += '<div class="swiper-slide">';
            jogo += '<ul class="catalogo-gallery-top grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 1) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 2) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            jogo += '</ul>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 2) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 3) {
            jogo += '<ul class="catalogo-gallery-bottom grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 3) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 4) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          else if (totalJogos != 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            jogoAtual = 0;
          }
          jogoAtual++;
        }
      });
      catalogoFinal.append(jogo);
    },
    error: function (erro) {
      console.log(erro);
    }
  })
});

// Pesquisa jogo por categoria no catálogo
$(".botaoFiltrar").click(function () {
  $(".catalogo-gallery-api").empty();
  if ($(this).data("valor") == 'all') {
    CarregaJogos();
    return;
  }
  $.ajax({
    url: "http://localhost:5064/api/Jogo/listajogosporcategoria?id=" + $(this).data("valor"),
    type: "get",
    contentType: 'application/json',
    success: function (dados) {
      var catalogoFinal = $('.catalogo-gallery-api');
      var totalJogos = 0;
      var jogoAtual = 1;
      var fim = false;
      var jogo = '';
      dados.forEach(function (item) {
        totalJogos++;
      });
      dados.forEach(function (item) {
        if (fim == false) {
          if (jogoAtual == 1) {
            jogo += '<div class="swiper-slide">';
            jogo += '<ul class="catalogo-gallery-top grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 1) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 2) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>';
            jogo += '</ul>';
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 2) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 3) {
            jogo += '<ul class="catalogo-gallery-bottom grid">';
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 3) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          if (jogoAtual == 4) {
            jogo += '<div class="' + item.idCategoria + ' item">'
            jogo += '<li>';
            jogo += '<a href="jogopg.html?idJogo=' + item.idJogo + '">'
            jogo += '<div class="card-catalogo">';
            jogo += '<img src="' + item.banner + '" alt="">';
            jogo += '<div class="card-info">';
            jogo += '<ul>';
            jogo += '<li>';
            jogo += '<h1>' + item.nome + '</h1>';
            jogo += '</li>';
            jogo += '</ul>';
            jogo += '</div>';
            jogo += '</div>';
            jogo += '</a>'
            jogo += '</li>';
            jogo += '</div>'
            totalJogos = totalJogos - 1;
          }
          if (totalJogos == 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            fim = true;
          }
          else if (totalJogos != 0 && jogoAtual == 4) {
            jogo += '</ul>';
            jogo += '</div>';
            jogoAtual = 0;
          }
          jogoAtual++;
        }
      });
      catalogoFinal.append(jogo);
    },
    error: function (erro) {
      console.log(erro);
    }
  })
});
