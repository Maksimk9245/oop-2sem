class Vector {
    x: number;
    y: number;

    constructor(x: number, y: number) {
        this.x = x;
        this.y = y;
    }

    length(): number {
        return Math.sqrt(this.x * this.x + this.y * this.y);
    }

    angle(): number {
        return Math.atan2(this.y, this.x) * (180 / Math.PI);
    }

    printVector(): void {
        console.log(`Координаты конца вектора: (${this.x}, ${this.y})`);
    }

    printPolarCoordinates(): void {
        console.log(`Длина вектора: ${this.length().toFixed(2)}`);
        console.log(`Угол (градусы): ${this.angle().toFixed(2)}`);
    }
}

function main(): void {
    const xInput: string | null = prompt("Введите координату x:");
    const yInput: string | null = prompt("Введите координату y:");

    const x: number = parseFloat(xInput ?? "0");
    const y: number = parseFloat(yInput ?? "0");

    const vector = new Vector(x, y);
    vector.printVector();
    vector.printPolarCoordinates();
}

main();
