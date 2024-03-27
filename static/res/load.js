function load(){
    loadCodeHighlight();
	loadImage();
	loadAnnouncement();
	loadHintConsole();
}
function loadCodeHighlight(){
    var elements = document.getElementsByClassName("codeTextarea");
    for(var a of elements){
        var cm = CodeMirror.fromTextArea(a, {
            lineNumbers: true,
            mode: "text/x-csharp",
            smartIndent: true,
            lineWrapping: true,
        });
        cm.setSize("auto", "auto");
        cm.refresh();
    }

    var elements = document.getElementsByClassName("outputTextarea");
    for(var a of elements){
        var cm = CodeMirror.fromTextArea(a, {
            lineNumbers: true,
            mode: "text/x-csharp",
            smartIndent: true,
            lineWrapping: true,
            theme: "ambiance"
        });
        cm.setSize("auto", "auto");
        cm.refresh();
    }
}
function loadImage(){
    var elements = document.getElementsByClassName("img");
    for(var a of elements){
        //console.log("***********" + a.src);
        //a.src = path + "../img/" + a.src);
        a.outerHTML = "<div class='imgboxer'>" + a.outerHTML + "<div style='position:relative;width:100%;'></div>" + "<span style='color:rgb(150,150,150)'>" + a.alt + "</span>" + "</div>";
    }
}
function loadAnnouncement(){
	var request = new XMLHttpRequest();
	request.open('GET', '../../../static/res/announcement.txt', false);
	request.send(null);
	if (request.status === 200) {
		document.getElementById("announcement").innerHTML = request.responseText;
	}
}
function loadHintConsole(){
	console.log('%c LICENSE: 未经允许，禁止商业使用本项目（包括使用本项目的任何CSS/JS做有营利性的网站，包括广告）。 The Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0) ', 
	'font-size:20px; background:rgb(255,255,0); color: black');
}
function getUrlParams(url) {
	let urlStr = url.split('?')[1]
	const urlSearchParams = new URLSearchParams(urlStr)
	const result = Object.fromEntries(urlSearchParams.entries())
	return result
}
