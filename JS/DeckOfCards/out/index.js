"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var jquery_1 = __importDefault(require("jquery"));
var deck_1 = require("./deck");
var currentDeck;
jquery_1.default(function () {
    function updatePageState(disabled) {
        jquery_1.default("#draw-card").prop('disabled', disabled);
        jquery_1.default('#draw-amount').prop('disabled', disabled);
        jquery_1.default("#remaining").trigger("change");
    }
    jquery_1.default("#new-deck").on('click', function () {
        deck_1.requestDeckInfo("https://deckofcardsapi.com/api/deck/new/")
            .then(function (deck) {
            currentDeck = new deck_1.DeckManager(deck);
            updatePageState(false);
        });
    });
    jquery_1.default("#draw-card").on('click', function () {
        if (!currentDeck) {
            return false;
        }
        var drawAmount = jquery_1.default("#draw-amount").val();
        currentDeck.drawCard(drawAmount).then(function (_) {
            if (currentDeck.remaining <= 0) {
                updatePageState(true);
            }
        });
    });
    jquery_1.default("#shuffle-deck").on('click', function () {
        if (!currentDeck) {
            return false;
        }
        currentDeck.shuffle();
        updatePageState(false);
    });
    jquery_1.default('#remaining').change(function () {
        var remaining = jquery_1.default(this).val();
        jquery_1.default('#draw-amount').attr('max', remaining);
    });
});
