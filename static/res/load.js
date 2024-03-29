function load(){
    loadCodeHighlight();
    loadImage();
    if(!isSpider()) loadAnnouncement();
    loadHintConsole();
}
function isSpider(){
    var userAgent = navigator.userAgent;
    console.log(userAgent);
    if(userAgent.indexOf("bot") != -1 || userAgent.indexOf("spider") != -1){
        console.log("SPIDER");
        return true;
    }else return false;
    // var botPattern = "(googlebot\/|bot|Googlebot-Mobile|Googlebot-Image|Google favicon|Mediapartners-Google|bingbot|slurp|java|wget|curl|Commons-HttpClient|Python-urllib|libwww|httpunit|nutch|phpcrawl|msnbot|jyxobot|FAST-WebCrawler|FAST Enterprise Crawler|biglotron|teoma|convera|seekbot|gigablast|exabot|ngbot|ia_archiver|GingerCrawler|webmon |httrack|webcrawler|grub.org|UsineNouvelleCrawler|antibot|netresearchserver|speedy|fluffy|bibnum.bnf|findlink|msrbot|panscient|yacybot|AISearchBot|IOI|ips-agent|tagoobot|MJ12bot|dotbot|woriobot|yanga|buzzbot|mlbot|yandexbot|purebot|Linguee Bot|Voyager|CyberPatrol|voilabot|baiduspider|citeseerxbot|spbot|twengabot|postrank|turnitinbot|scribdbot|page2rss|sitebot|linkdex|Adidxbot|blekkobot|ezooms|dotbot|Mail.RU_Bot|discobot|heritrix|findthatfile|europarchive.org|NerdByNature.Bot|sistrix crawler|ahrefsbot|Aboundex|domaincrawler|wbsearchbot|summify|ccbot|edisterbot|seznambot|ec2linkfinder|gslfbot|aihitbot|intelium_bot|facebookexternalhit|yeti|RetrevoPageAnalyzer|lb-spider|sogou|lssbot|careerbot|wotbox|wocbot|ichiro|DuckDuckBot|lssrocketcrawler|drupact|webcompanycrawler|acoonbot|openindexspider|gnam gnam spider|web-archive-net.com.bot|backlinkcrawler|coccoc|integromedb|content crawler spider|toplistbot|seokicks-robot|it2media-domain-crawler|ip-web-crawler.com|siteexplorer.info|elisabot|proximic|changedetection|blexbot|arabot|WeSEE:Search|niki-bot|CrystalSemanticsBot|rogerbot|360Spider|psbot|InterfaxScanBot|Lipperhey SEO Service|CC Metadata Scaper|g00g1e.net|GrapeshotCrawler|urlappendbot|brainobot|fr-crawler|binlar|SimpleCrawler|Livelapbot|Twitterbot|cXensebot|smtbot|bnf.fr_bot|A6-Indexer|ADmantX|Facebot|Twitterbot|OrangeBot|memorybot|AdvBot|MegaIndex|SemanticScholarBot|ltx71|nerdybot|xovibot|BUbiNG|Qwantify|archive.org_bot|Applebot|TweetmemeBot|crawler4j|findxbot|SemrushBot|yoozBot|lipperhey|y!j-asr|Domain Re-Animator Bot|AddThis)";
    // var re = new RegExp(botPattern, 'i');
    // var userAgent = navigator.userAgent; 
    // if (re.test(userAgent)) {
    //     console.log('the user agent is a crawler!');
    //     return true;
    // }else return false;
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
