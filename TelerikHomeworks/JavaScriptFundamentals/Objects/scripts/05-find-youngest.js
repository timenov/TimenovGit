//Write a function that finds the youngest person in a given array of persons and prints his/hers full name
//Each person have properties firstname, lastname and age

document.getElementById("submit").onclick = function(){
	var persons = [
			{firstname: "Pesho", lastname: "Marinkin", age: 23},
			{firstname: "Marina", lastname: "Pesheva", age: 32},
			{firstname: "Todor", lastname: "Todorov", age: 16},
			{firstname: "Kalina", lastname: "Marinkina", age: 25},
			{firstname: "Stavri", lastname: "Stavrev", age: 103},
			{firstname: "Lychezar", lastname: "Mishev", age: 88},
			{firstname: "Gosho", lastname: "Minchev", age: 7},
			{firstname: "Gatyo", lastname: "Tankov", age: 24}
		],
		youngest = findYoungest(persons);

	jsConsole.writeLine(youngest.firstname + ' ' + youngest.lastname + ' ' + youngest.age);
};

function findYoungest(persons) {
	var youngestIndex = 0,
		youngestAge = persons[0].age;

	for (var i = 0; i < persons.length; i++) {
		if (persons[i].age < youngestAge) {
			youngestIndex = i;
		}
	}

	return persons[youngestIndex];
};