//Write a function that makes a deep copy of an object
//The function should work for both primitive and reference types

document.getElementById("submit").onclick = function(){
	var num = 54,
		array = [1,2,3,4,5],
		clone = deepCloned(num);

	jsConsole.writeLine(clone);

	clone = deepCloned(array);

	jsConsole.writeLine(array.join(", "));
};

function deepCloned(objectToClone) {
	
	if (typeof(objectToClone) !== 'object') {
		return objectToClone;
	}

	var newClone = {},
		property;

	for (property in objectToClone) {
		newClone[property] = objectToClone[property];
	}

	return newClone;
};