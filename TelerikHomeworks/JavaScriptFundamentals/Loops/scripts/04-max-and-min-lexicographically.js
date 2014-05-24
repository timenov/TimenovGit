//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

document.getElementById("submit").onclick = findMinAndMax;

function findMinAndMax() {
	var objects = [document, window, navigator],
		object,
		properties;

	for (object in objects) {
		properties = Object.getOwnPropertyNames(objects[object]);

		properties.sort(function(a,b){
			if (a.toLowerCase() > b.toLowerCase()) return 1;
			if (a.toLowerCase() < b.toLowerCase()) return -1;
			return 0;
		});

		jsConsole.writeLine("smallest property from " + objects[object].toString() + " is: " + properties[0]);

		jsConsole.writeLine("largest property from " + objects[object].toString() + " is: " + properties[properties.length - 1]);
	}
};