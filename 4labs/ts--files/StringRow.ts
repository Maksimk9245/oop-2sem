export class StringRow {
    protected readonly value: string;

    constructor(value: string) {
        this.value = value;
    }

    get Value(): string {
        return this.value;
    }

    getLength(): number {
        return this.value.length;
    }
}
