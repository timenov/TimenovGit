/*
Write a script that parses an URL address given in the format:
and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.

For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
{protocol: "http",
 server: "www.devbg.org", 
 resource: "/forum/index.php"}
*/
jsConsole.writeLine('Enter URL addres');

document.getElementById("submit").onclick = function(){
	var parsedUrl = parseUrl(document.getElementById('input').value);

	jsConsole.writeLine('protocol: ' + parsedUrl.protocol);
	jsConsole.writeLine('server: ' + parsedUrl.server);
	jsConsole.writeLine('resource: ' + parsedUrl.resource);
};

function parseUrl(urlAddress) {
	var parsed,
		urlElements;
	parsed = urlAddress.replace('://', ' ');
	parsed = parsed.replace('/', ' ');

	urlElements = parsed.split(' ');

	return { protocol: urlElements[0],
			server: urlElements[1],
			resource: urlElements[2]};
}
