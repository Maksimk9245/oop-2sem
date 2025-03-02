class VectorTS {
    private x: number;
    private  y: number;

    constructor(x: number = 0, y: number = 0) {
        this.x = x;
        this.y = y;
    }

    getX(): number {
        return this.x;
    }

    getY(): number {
        return this.y;
    }

    toPolar(): { r: number; theta: number } {
        const r = Math.sqrt(this.x * this.x + this.y * this.y);
        const theta = Math.atan2(this.y, this.x);
        return { r, theta };
    }

    display(): void {
        console.log(`Вектор: (${this.x}, ${this.y})`);
        const polar = this.toPolar();
        console.log(`Полярные координаты: радиус = ${polar.r}, угол = ${polar.theta} радиан`);
    }
}

const v1 = new VectorTS(3, 4);
const v2 = new VectorTS(1, 2);
const v3 = new VectorTS(v1.getX(), v1.getY());

v1.display();
v2.display();
v3.display();