var quotes = [];

quotes.push("No, now go away or I shall taunt you a second time!");
quotes.push("I don't want to talk to you no more, you empty-headed animal food trough wiper!");
quotes.push("I fart in your general direction!");
quotes.push("Go and boil your bottoms, you sons of a silly person.");
quotes.push("I'm French. Why do you think I have this outrageous accent, you silly king?");

function taunt() {
    var quote = quotes[Math.floor(Math.random() * quotes.length)];
    alert(quote);
}