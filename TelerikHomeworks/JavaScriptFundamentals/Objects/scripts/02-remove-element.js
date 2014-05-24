//Write a function that removes all elements with a given value
//Attach it to the array type
//Read about prototype and how to attach methods

jsConsole.writeLine('array is: [1,2,1,4,1,3,4,1,111,3,2,1,"1"]');

var arrayToTest = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];

document.getElementById("submit").onclick = function(){
	arrayToTest.removeElement(1);
	jsConsole.writeLine(arrayToTest.join(", "));
};

Array.prototype.removeElement = function (element){
	var	indexOfElement = this.indexOf(element);

	while (indexOfElement >= 0) {
		this.splice(indexOfElement, 1);
		indexOfElement = this.indexOf(element);
	}
};