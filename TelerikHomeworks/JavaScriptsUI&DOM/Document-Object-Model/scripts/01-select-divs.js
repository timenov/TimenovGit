function selectDivsUsingStaticNode() {
	var innerDivs = document.querySelectorAll('div>div');

	return innerDivs.length;
};

function selectDivsUsingLiveNode() {
	var innerDivs = [],
		allDivs = document.getElementsByTagName('div'),
		len,
		i;

	for(i = 0, len = allDivs.length; i < len; i++) {
		if(allDivs[i].parentElement instanceof HTMLDivElement) {
			innerDivs.push(allDivs[i]);
		}
	}

	return innerDivs.length;
}

console.log('document.querySelectorAll(): ' + selectDivsUsingStaticNode());
console.log('document.getElementByTagName(): ' + selectDivsUsingLiveNode());