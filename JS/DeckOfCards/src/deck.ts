import $ from "jquery"
import { Card, displayCard, undisplayCard } from "./card"

export async function requestDeckInfo(request: RequestInfo): Promise<any> {

	const response = await fetch(request);
	const body = await response.json();

	return body;
}

export interface Deck {

	deck_id: number;
	remaining: number;
	shuffled: boolean;
	success: boolean;
}

export class DeckManager {

	id: number;
	remaining: number;

	constructor(deck: Deck) {

		console.log(deck.deck_id);

		this.id = deck.deck_id;
		this.remaining = deck.remaining;

		$("#deck-id").text(this.id);
		$("#remaining").attr('value', this.remaining);

		undisplayCard();
	}

	private updateRemaining(remaining: number) {

		this.remaining = remaining;
		$("#remaining").attr('value', this.remaining);
	}

	shuffle() {

		requestDeckInfo(`https://deckofcardsapi.com/api/deck/${this.id}/shuffle/`)
			.then(response => {

				this.updateRemaining(response.remaining);
				undisplayCard();
			});
	}

	drawCard(count: number): Promise<any> {

		return requestDeckInfo(`https://deckofcardsapi.com/api/deck/${this.id}/draw/?count=${count}`)
			.then(response => {

				for (let index in response.cards) {
					displayCard(response.cards[index] as Card);
				}

				this.updateRemaining(response.remaining);
			});
	}
}