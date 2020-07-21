class counter {

	constructor() {
		this.i = 0;
	}

	count() {
		return ++this.i;
	}
}

let counter1 = new counter();
console.log(counter1.count());
console.log(counter1.count());
console.log(counter1.count());

let counter2 = new counter();
console.log(counter2.count());
console.log(counter2.count());

console.log(counter1.count());

/*
function newCounter() {

	var i = 0;

	return function () {

		i++;
		return i;
	}
}

let counter1 = newCounter();
console.log(counter1());
console.log(counter1());
console.log(counter1());

let counter2 = newCounter();
console.log(counter2());
console.log(counter2());

console.log(counter1());*/