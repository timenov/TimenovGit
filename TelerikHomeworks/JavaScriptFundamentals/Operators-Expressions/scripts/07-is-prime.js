//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

document.getElementById("submit").onclick = isPrime;

function isPrime() {
	var number = document.getElementById("input").value;

	var isPrime = true;

	var i;
	for (i = 2; i < Math.sqrt(number); i++) {
		if ((number % i) === 0) {
			isPrime = false;
			break;
		};
	};

	jsConsole.writeLine("number is prime: " + isPrime);
};