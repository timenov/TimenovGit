/*
Write a function for extracting all email addresses from given text.
All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
Return the emails as array of strings.
*/

var text = 'some.user@issue.com svirka@kaval.com. system,iliev@gmail.com return';
jsConsole.writeLine(text);

document.getElementById("submit").onclick = function(){
	jsConsole.writeLine(findEmails(text));
};

function findEmails(text) {
    return text.match(/\w+@\w+\.\w+/g);
}
