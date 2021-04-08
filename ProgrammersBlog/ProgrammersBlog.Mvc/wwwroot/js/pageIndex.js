$(document).ready(function () {

    /* DataTables start here. */

    const dataTable = $('#pagesTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",
                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {

                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/Page/GetAllPages/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#pagesTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const pageResult = jQuery.parseJSON(data);
                            dataTable.clear();                          

                            if (pageResult.Data.ResultStatus === 0) {

                              
                                $.each(pageResult.Data.Pages.$values,
                                    function (index, page) {
                                        const newPage = getJsonNetObject(page, pageResult.Data.Pages.$values);
                                                        
                                        const newTableRow = dataTable.row.add([
                                            newPage.Id,                                          
                                            newPage.Title,
                                            `<img src="/img/${newPage.Thumbnail}" alt="${newPage.Title}" class="my-image-table"  style="max-height:50px; max-width:50px;" />`,                                                                         
                                            `${newPage.IsActive ? "Evet" : "Hayır"}`,
                                            `${newPage.IsDeleted ? "Evet" : "Hayır"}`,
                                            `${newPage.CreateDate}`,
                                            newPage.CreatedByName,
                                            `${newPage.ModifiedDate}`,
                                            newPage.ModifiedByName,
                                            `
                                <a class="btn btn-primary btn-sm btn-update" href="/Admin/Page/Update?pageId=${newPage.Id}"><span class="fas fa-edit"></span></a>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${newPage.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                        ]).node();
                                        const jqueryTableRow = $(newTableRow);
                                        jqueryTableRow.attr('name', `${newPage.Id}`);
                                    });
                                dataTable.draw();
                                $('.spinner-border').hide();
                                $('#pagesTable').fadeIn(1400);
                            } else {
                                toastr.error(`${pageResult.Data.Message}`, 'İşlem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#pagesTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    });
                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });

    //Datable end

    $(document).on('click',
        '.btn-delete',
        function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');        
            const tableRow = $(`[name="${id}"]`);
            const pageTitle = tableRow.find('td:eq(1)').text();
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                text: `${pageTitle} adlı sayfa silinicektir!`,
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet, silmek istiyorum.',
                cancelButtonText: 'Hayır, silmek istemiyorum.'
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { pageId: id },
                        url: '/Admin/Page/Delete/',
                        success: function (data) {
                            const pageResult = jQuery.parseJSON(data);
                         
                            if (pageResult.ResultStatus === 0) {
                                Swal.fire(
                                    'Silindi!',
                                    `${pageResult.Message}`,
                                    'success'
                                );

                                tableRow.fadeOut(3500);
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Başarısız İşlem!',
                                    text: `${pageResult.Message}`,
                                });
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(`${err.responseText}`, "Hata!");
                        }
                    });
                }
            });
        });

   
    // Trumbowyg başlangıç

    $('#text-editor').trumbowyg({
        btns: [
            ['viewHTML'],
            ['undo', 'redo'], // Only supported in Blink browsers
            ['formatting'],
            ['strong', 'em', 'del'],
            ['superscript', 'subscript'],
            ['link'],
            ['insertImage'],
            ['justifyLeft', 'justifyCenter', 'justifyRight', 'justifyFull'],
            ['unorderedList', 'orderedList'],
            ['horizontalRule'],
            ['removeformat'],
            ['fullscreen'],
            ['foreColor', 'backColor'],
            ['emoji'],
            ['fontfamily'],
            ['fontsize']
        ],
        plugins: {
            colors: {
                foreColorList: [
                    'ff0000', '00ff00', '0000ff', '54e346'
                ],
                backColorList: [
                    '000', '333', '555'
                ],
                displayAsList: false
            }
        }
    });

    // Trumbowyg bitiş
});