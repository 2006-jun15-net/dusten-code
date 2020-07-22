import $ from "jquery"

export interface Card {

	image: string;
	value: string;
	suit: string;
	code: string;
}

export function displayCard(card: Card) {

	$("#card").attr("src", card.image);
	$("#card").attr("title", `${card.value} OF ${card.suit}`);
}

export function undisplayCard() {

	$("#card").attr("src", "");
	$("#card").attr("title", "No card drawn");
}