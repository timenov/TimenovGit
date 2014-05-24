//Write a function that checks if a given object contains a given property

document.getElementById("submit").onclick = function(){
	var num = 54,
		array = [1,2,3,4,5];

	jsConsole.writeLine(hasProperty(num, "length"));

	jsConsole.writeLine(hasProperty(array, "length"));
};

function hasProperty(obj, prop) {
	return obj.hasOwnProperty(prop);
};