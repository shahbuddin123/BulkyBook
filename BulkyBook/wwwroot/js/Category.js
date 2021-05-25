var dataTable;

$(document).ready(function () {
    loadDataTable();

});
function loadDataTable() {
    database = $('#tbldata').DataTable({
        ajax: {
            "url": "/Admin/Category/GetAll"
        },
        "Columns": [
            { "data": "name", "width": "60%" },
            {
                "data": "id",
                "render": function (data) {
                    return 
                  

    
                }
            }
        ]

    })
}