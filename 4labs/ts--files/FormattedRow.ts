import { StringRow } from './StringRow';

export class FormattedRow extends StringRow {
    constructor(value: string) {
        super(value);
    }

    getWordCount(): number {
        return this.Value.trim().split(/\s+/).length;
    }

    printInfo(): void {
        console.log(`Рядок: ${this.Value}`);
        console.log(`Довжина: ${this.getLength()}`);
        console.log(`Кількість слів: ${this.getWordCount()}`);
    }
}
