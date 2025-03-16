class Square {
    constructor(public x: number = 0, public y: number = 0, public sideLength: number = 1) {}
    
    get area(): number { return this.sideLength ** 2; }
    get perimeter(): number { return this.sideLength * 4; }
    
    clone(): Square { return new Square(this.x, this.y, this.sideLength); }
    add(value: number): Square { return new Square(this.x, this.y, this.sideLength + value); }
    divide(value: number): Square { 
        if (value === 0) throw new Error("Cannot divide by zero");
        return new Square(this.x, this.y, this.sideLength / value); 
    }
    addSquare(square: Square): Square { return new Square(this.x, this.y, this.sideLength + square.sideLength); }
    
    toString(): string {
        return `Square: X=${this.x}, Y=${this.y}, SideLength=${this.sideLength}, Area=${this.area}, Perimeter=${this.perimeter}`;
    }
}

const K1 = new Square(1, 1, 4);
const K2 = new Square(2, 2, 5);
const K3 = new Square(3, 3, 6);

console.log("Initial squares:");
console.log(K1.toString());
console.log(K2.toString());
console.log(K3.toString());

const K3Increased = K3.add(1);
console.log("After increasing K3 by 1:", K3Increased.toString());

let result: Square;
try {
    result = K2.divide(K3.sideLength);
    console.log("After dividing K2 by K3:", result.toString());
} catch (error) {
    console.log("Error:", error.message);
    result = new Square();
}

const K1Updated = K1.addSquare(result);
console.log("After adding to K1:", K1Updated.toString());
