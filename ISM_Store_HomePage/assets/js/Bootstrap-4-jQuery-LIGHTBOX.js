$( document ).ready(function() {
    
    $( ".lightbox-enabled" ).click(function() {
        var src = $(this).attr("src");
        var title = $(this).attr("alt");
        var image = $("#modal-lightbox-body").find("img");
        image.attr("src", src);
        
        if(title == null)
            $("#modal-lightbox-title").html("Image");
        else
            $("#modal-lightbox-title").html(title);
            
        
        $("#modal-lightbox").modal("show");
    });
    
});
