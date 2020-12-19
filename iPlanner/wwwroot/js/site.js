$(init);
function init() {
    $(".task").draggable();
    $(".tasks").droppable({
        drop: function (event, ui) {
            ui.draggable.removeClass("ui-draggable ui-draggable-handle");
            ui.draggable.removeAttr("style");
            ui.draggable.attr("prevBoard", ui.draggable.parents(".board").attr("id"));
            ui.draggable.removeAttr("style");
            ui.draggable.attr("style", "position: relative;");
            $(this).append($("#" + ui.draggable.attr("id"))[0]);
            var id = ui.draggable.attr("id").replace("card-", "");
            if (ui.draggable.attr("prevBoard") != ui.draggable.parents(".board").attr("id")) {
                window.location.href = '/Cards/Edit/' + id;
            }
        }
    });
    $(".task").contextmenu(function (e) {
        e.preventDefault();
        var id = this.getAttribute("id").replace("card-", "");
        window.location.href = '/Cards/Delete/' + id;
    });
}
function showAddForm() {
    $(".addForm").show(function () {
        alert("add form");
    });
}