//Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.

var array = [1,1,2,3,4,4,4,5,6,6,6,7,8,9,9];

jsConsole.writeLine(array);

document.getElementById("submit").onclick = function() {var number = parseInt(document.getElementById("input").value);
														jsConsole.writeLine("counts of " + number + ": " + occsOf(array, number))};

function occsOf(array, element) {
	return array.filter(function(el){
		return el === element
	}).length;
};