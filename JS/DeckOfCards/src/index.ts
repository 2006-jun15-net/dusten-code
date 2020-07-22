import $ from "jquery"

import { Deck, DeckManager, requestDeckInfo } from "./deck"
import { displayCard } from "./card";

var currentDeck: DeckManager;

$(function () {

	function updatePageState(disabled: boolean) {

		$("#draw-card").prop('disabled', disabled);
		$('#draw-amount').prop('disabled', disabled);

		$("#remaining").trigger("change");
	}

	$("#new-deck").on('click', function () {

		requestDeckInfo("https://deckofcardsapi.com/api/deck/new/")
			.then(deck => {

				currentDeck = new DeckManager(deck as Deck);
				updatePageState(false);
			});
	});

	$("#draw-card").on('click', function () {

		if (!currentDeck) {
			return false;
		}

		let drawAmount = $("#draw-amount").val() as number;

		currentDeck.drawCard(drawAmount).then(_ => {

			if (currentDeck.remaining <= 0) {
				updatePageState(true);
			}
		});
	});

	$("#shuffle-deck").on('click', function () {

		if (!currentDeck) {
			return false;
		}

		currentDeck.shuffle();
		updatePageState(false);
	});

	$('#remaining').change(function () {

		let remaining = $(this).val() as string;
		$('#draw-amount').attr('max', remaining);
	});
});