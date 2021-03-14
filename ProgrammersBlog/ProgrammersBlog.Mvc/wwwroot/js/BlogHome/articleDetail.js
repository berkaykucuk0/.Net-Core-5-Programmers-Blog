$(document).ready(function () {
 
    $(function () {
       
        $(document).on('click', '#btnSave', function (event) {
        
            event.preventDefault();
            const form = $('#form-comment-add');
            const actionUrl = form.attr('action');
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend).done(function (data) {

                const commentAddAjaxModel = jQuery.parseJSON(data);
              
                const newFormBody = $('.form-card', commentAddAjaxModel.CommentAddPartial);
                const cardBody = $('.form-card');
                cardBody.replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                console.log(isValid);
                if (isValid) {
                  
                    const newSingleComment = ` <div class="comment-list">
                                        <div class="single-comment justify-content-between d-flex">
                                            <div class="user justify-content-between d-flex">
                                                <div class="thumb">
                                                        <img src="https://randomuser.me/api/portraits/men/34.jpg" style="max-width:50px; max-height:50px">
                                                </div>
                                                <div class="desc">
                                                    <h5>${commentAddAjaxModel.CommentDto.Comment.CreatedByName}</h5>
                                                    <p class="date">${commentAddAjaxModel.CommentDto.Comment.CreateDate}</p>
                                                    <p class="comment">
                                                        ${commentAddAjaxModel.CommentDto.Comment.Text}
                                                    </p>
                                                </div>
                                            </div>                                           
                                        </div>
                                    </div>`;
                    const newSingleCommentObject = $(newSingleComment);
                  
                    newSingleCommentObject.hide();
                    $('#comments').append(newSingleCommentObject);
                    newSingleCommentObject.fadeIn(3000);
                    toastr.success(`Sayın ${commentAddAjaxModel.CommentDto.Comment.CreatedByName}, yorumunuz başarıyla eklenmiştir.Yorumunuz onaylandıktan sonra görünecektir.`);
                    $('#btnSave').prop('disabled', true);
                    setTimeout(function () {
                        $('#btnSave').prop('disabled', false);
                    }, 5000);
                }
                else {
                      let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText += `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                }
            }).fail(function (error) {

                console.error(error);
            });

        });
    });
});