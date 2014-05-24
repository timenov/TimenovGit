/*
Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/

var text = 'some words abba with and without lamal palindromes exe';
jsConsole.writeLine(text);

document.getElementById("submit").onclick = function(){
	jsConsole.writeLine(text.match(/\w+/g).filter(function(word) {
        return isPalindrome(word)
	}));
};

function isPalindrome(text) {
    var i

    for (i = 0; i < parseInt(text.length / 2, 10); i++){
        if (text[i] !== text[text.length - 1 - i]){
            return false;
        }
    }

    return true;
};