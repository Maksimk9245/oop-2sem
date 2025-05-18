class Calculation {
    private a: number;
    private c: number;

    constructor(a: number, c: number) {
        this.a = a;
        this.c = c;
    }

    calculateExpression(): number {
        if (this.c === -this.a) {
            throw new Error("Division by zero is not allowed.");
        }

        return Math.log((2 * this.c - this.a) + 4 - 152) / (this.a / this.c);
    }
}

const calculations: Calculation[] = [
    new Calculation(4, 2),
    new Calculation(5, -5),
    new Calculation(3, 3)
];

calculations.forEach((calc, index) => {
    try {
        console.log(`Result for calculation ${index + 1}: ${calc.calculateExpression()}`);
    } catch (error) {
        console.error(`Error for calculation ${index + 1}: ${(error as Error).message}`);
    }
});
