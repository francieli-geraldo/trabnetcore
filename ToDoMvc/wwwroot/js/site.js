// Write your JavaScript code.
$(documento).ready(function(){
    $('#add-item-buton')
    .on('click', addItems);
});

function addItems(){
    $('#add-item-error').hide();
    var newTitle = $('#add-item-title').val();

    var data = { title: newTitle };
$.post('ToDo/AddItem', data, function(){window.location = '/ToDo';}).fail(function(data){  
    if(!data || !data.responseJSON)

        return;

    var key = Object.keys(data.responseJSON)[0];
    var firstError = data.responseJSON[key];
    $('#add-item-error').text(firstError).show();
});
}