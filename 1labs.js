class Vector {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    length() {
        return Math.sqrt(this.x * this.x + this.y * this.y);
    }

    angle() {
        return Math.atan2(this.y, this.x) * (180 / Math.PI); // угол в градусах
    }

    printVector() {
        console.log(`Координаты конца вектора: (${this.x}, ${this.y})`);
    }

    printPolarCoordinates() {
        console.log(`Длина вектора: ${this.length().toFixed(2)}`);
        console.log(`Угол (градусы): ${this.angle().toFixed(2)}`);
    }
}

function main() {
    const x = parseFloat(prompt("Введите координату x:") || "0");
    const y = parseFloat(prompt("Введите координату y:") || "0");

    const vector = new Vector(x, y);
    vector.printVector();
    vector.printPolarCoordinates();
}

main();
