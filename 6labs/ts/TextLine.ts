import { ICaseChanger } from "./ICaseChanger";

export class TextLine implements ICaseChanger {
    private content: string;

    constructor(text: string) {
        this.content = text;
    }

    toUpperCase(): string {
        return this.content.toUpperCase();
    }

    toLowerCase(): string {
        return this.content.toLowerCase();
    }

    capitalizeWords(): string {
        return this.content
            .split(' ')
            .map(word => word.charAt(0).toUpperCase() + word.slice(1).toLowerCase())
            .join(' ');
    }

    getContent(): string {
        return this.content;
    }

    setContent(newContent: string): void {
        this.content = newContent;
    }
}
