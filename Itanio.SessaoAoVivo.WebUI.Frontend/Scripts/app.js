SessaoAoVivo.isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent);


SessaoAoVivo.App = (function () {
    var $public = {}, $private = {};
    

    $private.initializeToastr = function () {
        $public.toastr = toastr;
        $public.toastr.options = {
            "closeButton": true,
            "debug": false,
            "progressBar": true,
            "positionClass": "toast-bottom-right",
            "onclick": null,
            "showDuration": "400",
            "hideDuration": "1000",
            "timeOut": "3000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
    };

 

    $private.initializeDropdownJs = function () {
        $("select.dropdownjs").dropdownjs();
    };
     
    $public.AdicionarNotificacao = function (notificacao) {
        $private.Notificacoes.push(notificacao);
    };

    $public.InicializarControles = function () {
        for (var x = 0; x < $private.Notificacoes.length; x++) {
            $public.toastr[$private.Notificacoes[x].TipoMensagem]($private.Notificacoes[x].Mensagem, $private.Notificacoes[x].TituloMensagem);
        }
        $private.Notificacoes = [];
    };

    $private.resizeSlimControl = function () {

        if ($private.mhResizeTimeout) {
            window.clearTimeout($private.mhResizeTimeout);
        }
        $private.mhResizeTimeout = 0;
        $private.mhResizeTimeout = window.setTimeout(doResizeStuff, 100);

    };

    function doResizeStuff() {
        $private.mhResizeTimeout = 0;
        $public.initializeSlimControl(false);
    }

    $public.initializeSlimControl = function (restart) {
        if (!SessaoAoVivo.isMobile) {
            if ($private.resize || restart) {
                $('.sidebar-container').slimScroll({ destroy: true });
            }
            $('.sidebar-container').slimScroll({
                height: window.innerHeight - $(".navbar").height() - $(".footer").height() - 40,
                railOpacity: 0.4,
                size: 10,
            });
            $private.resize = true;
        }
        else {
            $('.sidebar-container').css({
                "height": (window.innerHeight - $(".navbar").height() - $(".footer").height() - 40) + "px",
                "overflow": "auto"
            });
        }
    };


    $(function () {
        $private.Notificacoes = [];
      
        $private.initializeDropdownJs();
        $private.initializeToastr();
        $(window).on("resize", $private.resizeSlimControl);

        $(document).ajaxError(function (event, xhr, options, thrownError) {
            var erro = $(xhr.responseText).filter("span").find("h2 > i").text();
            if (erro != "")
                $public.toastr["error"](erro, "Erro")
        });
    });


    return $public;

}());

