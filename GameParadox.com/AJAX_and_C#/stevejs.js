// JScript File

// JScript File

var xmlHttp;


var server = true;
var url    = "";


function redirect(url)
{
  document.location = url;
  

}

function hello()
{
   
   

  alert("Hi");
  var url = "http://www.gameparadox.com/gethint.aspx?sid=" + "adx";
  xmlHttp = GetXmlHttpObject(test);
  xmlHttp.open("GET",url,true);
  alert("Hi 2");

 xmlHttp.send(null);
   
   
}

function getRate(name)
{
  //when this function is called it will get the rate of the game 
  //for us 
  //alert("Hi");
  
  //var url = "http://www.gameparadox.com/gethint.aspx?sid=" + "getRate";
 // xmlHttp = GetXmlHttpObject(getRate);
 // xmlHttp.open("GET",url,true);  
}


//logs a link into sql database using ajax calls
function jsTrackClick(link)
{
      url = "LoghtmlLink.aspx?link="+link;
      xmlHttp = GetXmlHttpObject(htmlLogClick);
      xmlHttp.open("GET",url,true);
      xmlHttp.send(null);
}

function  htmlLogClick()
{


}


function getImage(image)
{
    
    //alert("calling get image " + image);
    var scr_local = "http://local:2747/gameparadox.com/gameparadox_ReviewArt/"
    var value = document.getElementById("BigImage").src = "http://localhost:2747/gameparadox/gameparadox_ReviewArt/" + image 
    // var value = document.getElementById("BigImage").src = "http://www.gameparadox.com/gameparadox_ReviewArt/" + image; 
    // alert("What is the value of big image " + value);
}



function allgames1(x) // just for calling the initial call the first time
{
 

     var something = document.getElementById("body");// = body;
     var hidden = document.getElementById("hidden");
     document.getElementById("ajaxout").innerHTML= "Loading ....";
     // alert("what is allgame(x) " + x);
     // alert("call this for the link options ************ ");
     // something.setAttribute('onload','allgames(0)');
     //var url = "http://www.gameparadox.com/gethint.aspx?sid=" + "allgames";
 
     if(server)
     url = "http://www.gameparadox.com/gethint.aspx?sid=" + "allgames" +"?index=" + x;
     else 
     url = "gethint.aspx?sid=" + "allgames"+"?index="+x;

      xmlHttp = GetXmlHttpObject(test);
      xmlHttp.open("GET",url,true);
      xmlHttp.send(null);
   //   alert("This is the last line of allgames1 " );
}

function allgames() // just for calling the initial call the first time
{
   var hidden = document.getElementById("hidden");
   if(something.getAttribute('onload') == "check()" && hidden.value == 0)
   {  
      alert(something.getAttribute('onload'));
      something.setAttribute('onload','allgames(0)');
      var usr ="";
      
      if(server)
      url = "http://www.gameparadox.com/gethint.aspx?sid=" + "allgames" +"?index="+"0";
      else    
      url = "gethint.aspx?sid=" + "allgames"+"?index="+"0";
      
      xmlHttp = GetXmlHttpObject(test);
      xmlHttp.open("GET",url,true);
      // alert("Hi 2");
      xmlHttp.send(null);
      
      hidden.value = 1;
   }
   
//alert(something.getAttribute('onload'));
   
}



function allgames(x) // just for calling the initial call the first time
{
      var url = "gethint.aspx?sid=" + "allgames" +"?index="+x;
      xmlHttp = GetXmlHttpObject(test1);
      xmlHttp.open("GET",url,true);
      xmlHttp.send(null);
}


function test1() 
{ 
if (xmlHttp.readyState==4 || xmlHttp.readyState=="complete")
{ 
  //document.getElementById("ajaxout").innerHTML=xmlHttp.responseText 
  var data = xmlHttp.responseText;
  document.getElementById("ajaxout").innerHTML= data;

} 
} 
    
    
function test() 
{ 
if (xmlHttp.readyState==4 || xmlHttp.readyState=="complete")
{ 
  //document.getElementById("ajaxout").innerHTML=xmlHttp.responseText 
  //alert("calling the test function now ");
  var data = xmlHttp.responseText;
  document.getElementById("ajaxout").innerHTML= data;
  //alert("What is the ajax that is return " + s);
  //alert("What is the size of the array " + links.length);
  //  alert(links[1]); 
  //alert(xmlHttp.responseText);
  // alert(something.getAttribute('onload'));
} 
} 



function GetXmlHttpObject(handler)
{ 
var objXmlHttp=null

if (navigator.userAgent.indexOf("Opera")>=0)
{
alert("This example doesn't work in Opera") 
return 
}
if (navigator.userAgent.indexOf("MSIE")>=0)
{ 
var strName="Msxml2.XMLHTTP"
if (navigator.appVersion.indexOf("MSIE 5.5")>=0)
{
strName="Microsoft.XMLHTTP"
} 
try
{ 
objXmlHttp=new ActiveXObject(strName)
objXmlHttp.onreadystatechange=handler 
return objXmlHttp
} 
catch(e)
{ 
alert("Error. Scripting for ActiveX might be disabled") 
return 
} 
} 
if (navigator.userAgent.indexOf("Mozilla")>=0)
{
objXmlHttp=new XMLHttpRequest()
objXmlHttp.onload=handler
objXmlHttp.onerror=handler 
return objXmlHttp
}
} 
