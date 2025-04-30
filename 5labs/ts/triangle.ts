import Figure from './figure';

type Point = { x: number; y: number };

class Triangle extends Figure {
  private A: Point;
  private B: Point;
  private C: Point;

  constructor(ax: number, ay: number, bx: number, by: number, cx: number, cy: number) {
    super();
    this.A = { x: ax, y: ay };
    this.B = { x: bx, y: by };
    this.C = { x: cx, y: cy };
  }

  private distance(p1: Point, p2: Point): number {
    return Math.sqrt((p1.x - p2.x) ** 2 + (p1.y - p2.y) ** 2);
  }

  getPerimeter(): number {
    return this.distance(this.A, this.B) + this.distance(this.B, this.C) + this.distance(this.C, this.A);
  }

  getArea(): number {
    const a = this.distance(this.A, this.B);
    const b = this.distance(this.B, this.C);
    const c = this.distance(this.C, this.A);
    const s = (a + b + c) / 2;
    return Math.sqrt(s * (s - a) * (s - b) * (s - c)); // Герон
  }

  override print(): void {
    console.log("Triangle:");
    super.print();
  }
}

export default Triangle;
