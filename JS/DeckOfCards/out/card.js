"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.undisplayCard = exports.displayCard = void 0;
var jquery_1 = __importDefault(require("jquery"));
function displayCard(card) {
    jquery_1.default("#card").attr("src", card.image);
    jquery_1.default("#card").attr("title", card.value + " OF " + card.suit);
}
exports.displayCard = displayCard;
function undisplayCard() {
    jquery_1.default("#card").attr("src", "");
    jquery_1.default("#card").attr("title", "No card drawn");
}
exports.undisplayCard = undisplayCard;
