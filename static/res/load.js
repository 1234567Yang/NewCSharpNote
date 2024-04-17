setTimeout(load, 100);
//load();

function load(){
    loadCodeHighlight();
    loadImage();
    loadHintConsole();
    if(!isSpider()){
        loadHeader();
        loadFooter();
        loadAnnouncement();
    }


    if(!isSpider()){
        loadAnalysis();
        loadAds(); //一定要放在最后！
    }
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
function loadHeader(){
    var request = new XMLHttpRequest();
	request.open('GET', '../../../static/res/header.txt', false);
	request.send(null);
	if (request.status === 200) {
		document.getElementById("header").outerHTML = request.responseText;
	}
}
function loadFooter(){
    var request = new XMLHttpRequest();
	request.open('GET', '../../../static/res/footer.txt', false);
	request.send(null);
	if (request.status === 200) {
		document.getElementById("footer").outerHTML = request.responseText;
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
	console.log('%c 未经许可，禁止重新分发、复制、修改、翻译、传唤、传真、传感、传染本资料。Unauthorized Redistribution: Without permission, refrain from redistributing, copying, modifying, translating, summoning, parking, fishing, or infecting this material.', 
	'font-size:20px; background:rgb(255,255,0); color: black');
}
function loadAds(){
    setTimeout(function() {
        console.log("loading ads.");
        var script = document.createElement("script");
        script.src = "https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js?client=ca-pub-4204717380896480";
        script.async = true;
        script.crossOrigin = "anonymous";
        document.body.appendChild(script);
        console.log("loaded ads.");
    }, 1000);  // 延迟1秒加载脚本
}
function loadAnalysis(){
    var script = document.createElement("script");
    script.src = "https://www.googletagmanager.com/gtag/js?id=G-21XVVP88DK";
    document.body.appendChild(script);

    
    window.dataLayer = window.dataLayer || [];
    function gtag(){dataLayer.push(arguments);}
    gtag('js', new Date());
  
    gtag('config', 'G-21XVVP88DK');
}
function getUrlParams(url) {
	let urlStr = url.split('?')[1]
	const urlSearchParams = new URLSearchParams(urlStr)
	const result = Object.fromEntries(urlSearchParams.entries())
	return result
}
