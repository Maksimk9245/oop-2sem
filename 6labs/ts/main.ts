import { TextLine } from "./TextLine";
import { TextContainer } from "./TextContainer";

const container = new TextContainer();

const line1 = new TextLine("typescript is cool");
const line2 = new TextLine("let's CODE!");

container.addLine(line1);
container.addLine(line2);

console.log(line1.capitalizeWords());
console.log(line2.toLowerCase());

container.showAll();
