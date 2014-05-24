/*
Write a function that formats a string using placeholders:
var str = stringFormat("Hello {0}!","Peter");
//str = "Hello Peter!";

The function should work with up to 30 placeholders and all types
var format = "{0}, {1}, {0} text {2}";
var str = stringFormat(format,1,"Pesho","Gosho");
//str = "1, Pesho, 1 text Gosho"
*/

document.getElementById("submit").onclick = function(){
	jsConsole.writeLine(format('{0}, {1}!', 'Hello', 'World'));
};

function format(str) {
    var selfArguments = arguments

    return str.replace(/\{(\d+)\}/g, function(match, p1) {
        return selfArguments[+p1 + 1]
    })
};