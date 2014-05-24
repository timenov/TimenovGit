//Write a script that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

document.getElementById("submit").onclick = maxIncreasingSequence;

function maxIncreasingSequence() {
	var array = [1,1,0,0,1,2,3,4,4,4,5,6,6,6,7,7,7,7,8,9],
		counter = 1,
		max = 0,
		maxStartIndex = 0,
		i;

	for (i = 0; i < array.length - 1; i++) {
		if (array[i] === (array[i + 1] - 1)) {
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