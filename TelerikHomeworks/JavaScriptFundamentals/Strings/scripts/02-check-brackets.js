//Write a JavaScript function to check if in a given expression the brackets are put correctly.

document.getElementById("submit").onclick = function(){jsConsole.writeLine(checkBrackets(document.getElementById('input').value));};

function checkBrackets(input){
	var bracketsStack = 0;
    
    for (var i = 0; i < input.length; i++)
    {
        if (input[i] === '(') {
            bracketsStack++;
        } else if (input[i] === ')') {
            bracketsStack--;
        }

        if (bracketsStack < 0) {
            return false;
        }
    }

    return !bracketsStack;
}