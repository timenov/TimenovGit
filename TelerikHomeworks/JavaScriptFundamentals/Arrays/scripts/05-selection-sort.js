//Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm:
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

document.getElementById("submit").onclick = selectionSort;

function selectionSort() {
	var array = [2,1,3,4,5,1,7,9,8,6],
		minIndex = 0,
		temp,
		i,
		j;

	jsConsole.writeLine("unsorted array: " + array.join(", "));

	for (i = 0; i < array.length - 1; i++) {
		minIndex = i;
		
		for (j = i; j < array.length; j++) {
			if (array[j] < array[minIndex]) {
				minIndex = j;
			};
		};

		temp = array[i];
		array[i] = array[minIndex];
		array[minIndex] = temp;
	};

	jsConsole.writeLine("sorted array: " + array.join(", "));
};