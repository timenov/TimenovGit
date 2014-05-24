/*
You are given a text. Write a function that changes the text in all regions:
<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
*/

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
console.log(text);

jsConsole.writeLine("F12 for see input text.");

document.getElementById("submit").onclick = function(){jsConsole.writeLine(executeFormatting(text));};

function toMixCase(str) {
        var replaced = ''
          , i

        for (i = 0; i < str.length; i++)
            replaced += str.charAt(i)[Math.round(Math.random()) ? 'toLowerCase' : 'toUpperCase']()

        return replaced
    }

function executeFormatting(str) {
    return str.replace(/<upcase>(.*?)<\/upcase>/g, function(match, p1) {
        return p1.toUpperCase()
    }).replace(/<lowcase>(.*?)<\/lowcase>/g, function(match, p1) {
        return p1.toLowerCase()
    }).replace(/<mixcase>(.*?)<\/mixcase>/g, function(match, p1) {
        return toMixCase(p1)
    })
}
