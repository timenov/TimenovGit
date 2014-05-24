//Write a JavaScript function reverses string and returns it

document.getElementById("submit").onclick = function(){jsConsole.writeLine(reverse(document.getElementById('input').value));};

function reverse(input){
	return input.split('').reverse().join('');
}