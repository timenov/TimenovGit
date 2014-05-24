//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

document.getElementById("submit").onclick = createSimpleArray;

function createSimpleArray() {
	var arr = new Array(20),
		i = 0;

	for (i = 0; i < arr.length; i++) {
		arr[i] = i * 5;
	};

	jsConsole.writeLine(arr.join());
};