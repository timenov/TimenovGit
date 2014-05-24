//Write a function that groups an array of persons by age, first or last name.
//The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups

document.getElementById("submit").onclick = function(){
	var persons = [
			{firstname: "Pesho", lastname: "Marinkin", age: 23},
			{firstname: "Marina", lastname: "Pesheva", age: 32},
			{firstname: "Todor", lastname: "Todorov", age: 16},
			{firstname: "Kalina", lastname: "Marinkina", age: 25},
			{firstname: "Pesho", lastname: "Stavrev", age: 103},
			{firstname: "Lychezar", lastname: "Mishev", age: 88},
			{firstname: "Gosho", lastname: "Minchev", age: 27},
			{firstname: "Gatyo", lastname: "Tankov", age: 24}
		],
		groupByFirstName = groupBy(persons, 'firstname');

	printGrouped(groupByFirstName);
};

function groupBy(arr, prop) {
	var grouped = { };

	for (var item in arr) {
		if (!grouped[arr[item][prop]]) {
			grouped[arr[item][prop]] = [];
		}

		grouped[arr[item][prop]].push(arr[item]);
	}

	return grouped;
};

function printGrouped(arr){
	for (var prop in arr) {
		jsConsole.writeLine(arr[prop]);
	}
};