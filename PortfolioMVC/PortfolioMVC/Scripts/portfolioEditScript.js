//function uploadPreview() {
//    var imgprev = $('#pic');
//    var upload = $('#uploader')[0];
//    var reader = new FileReader();

//    reader.onload = function () {
//        imgprev.src = reader.result;
//    }

//    if (upload)
//        reader.readAsDataURL(upload);
//    else
//        imgprev.src = "";
//}

//uploadPreview();
function onFileSelected(event) {
    var selectedFile = event.target.files[0];
    var reader = new FileReader();
    var pic = $('#pic')[0];
    //var holder = $('#pic_hidden')[0];
    //var vid={name:'',media_type:'',source:''};
    reader.onload = function (event) {
        pic.src = event.target.result;
        //holder.value = event.target.result;
    }
    reader.readAsDataURL(selectedFile);
};
var status = $('#test_data');
var drop = $('#uploader');
var img = $('#pic');

if (window.FileReader) {
    addEventHandler(window, 'load', function () {


        function cancel(e) {
            if (e.preventDefault) { e.preventDefault(); }
            return false;
        }

        // Tells the browser that we *can* drop on this target
        addEventHandler(drop, 'dragover', cancel);
        addEventHandler(drop, 'dragenter', cancel);
    });
} else {
    $('#test_data').innerHTML = 'Your browser does not support the HTML5 FileReader.';
}
function addEventHandler(obj, evt, handler) {
    if (obj.addEventListener) {
        // W3C method
        obj.addEventListener(evt, handler, false);
    } else if (obj.attachEvent) {
        // IE method.
        obj.attachEvent('on' + evt, handler);
    } else {
        // Old school method.
        obj['on' + evt] = handler;
    }
}
addEventHandler(drop, 'drop', function (e) {
    e = e || window.event; // get window.event if e argument missing (in IE)   
    if (e.preventDefault) { e.preventDefault(); } // stops the browser from redirecting off to the image.

    var data = e.dataTransfer;
    var file = data.files[0];

    var reader = new FileReader();

    //attach event handlers here...

    reader.readAsDataURL(file);

    return false;
});
addEventHandler(reader, 'loadend', function (e, file) {
    var bin = this.result;
    img.src = bin;
}.bindToEventHandler(file));