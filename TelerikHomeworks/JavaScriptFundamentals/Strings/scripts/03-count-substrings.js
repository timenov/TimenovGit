//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

jsConsole.writeLine(text + "<br /><br />Enter substring for counting.");

document.getElementById("submit").onclick = function(){jsConsole.writeLine(countSubstr(text, document.getElementById('input').value));};

function countSubstr(text, phrase){
	var counts = 0,
		index = 0;
    
    while (text.toLowerCase().indexOf(phrase.toLowerCase(), index) !== -1) {
    	counts++;
    	index = text.toLowerCase().indexOf(phrase.toLowerCase(), index) + 1;
    }

    return counts;
}