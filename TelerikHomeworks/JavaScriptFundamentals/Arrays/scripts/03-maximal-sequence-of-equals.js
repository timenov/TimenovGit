//Write a script that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

document.getElementById("submit").onclick = maxSequence;

function maxSequence() {
	var array = [1,2,3,4,4,4,5,6,6,6,7,7,7,7,8,9],
		counter = 1,
		max = 0,
		maxStartIndex = 0,
		i;

	for (i = 0; i < array.length - 1; i++) {
		if (array[i] === array[i + 1]) {
			counter++;

			if (counter > max) {
				max = counter;
				maxStartIndex = (i + 2) - max;
			}

		}else{
			counter = 1;
		}
	};

	jsConsole.writeLine("the array is: " + array.join(", "));

	jsConsole.writeLine("max sequence is from " + max + " elements: " + array.slice(maxStartIndex, maxStartIndex + max).join(", "));
};