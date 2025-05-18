import { TextLine } from "./TextLine";

export class TextContainer {
    private lines: TextLine[] = [];

    addLine(line: TextLine): void {
        this.lines.push(line);
    }

    removeLine(index: number): void {
        this.lines.splice(index, 1);
    }

    showAll(): void {
        this.lines.forEach(line => console.log(line.getContent()));
    }
}
