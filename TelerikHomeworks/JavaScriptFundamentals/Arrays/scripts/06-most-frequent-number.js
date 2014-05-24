//Write a program that finds the most frequent number in an array.

document.getElementById("submit").onclick = mostFrequentNumber;

function mostFrequentNumber() {
	var array = [1,2,7,3,6,7,4,7,4,1,4,7,5,6,1,6,7,7,8,1,9],
		counter = 1,
		maxCount = 0,
		value,
		i;
	
	jsConsole.writeLine("the array is: " + array.join(", "));

	array.sort();

	for (i = 0; i < array.length - 1; i++) {
		if (array[i] === array[i + 1]) {
			counter++;

			if (counter > maxCount) {
				maxCount = counter;
				value = array[i];
			}

		}else{
			counter = 1;
		}
	};

	jsConsole.writeLine( + value + " (" + maxCount + " times)");
};