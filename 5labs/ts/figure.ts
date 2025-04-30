abstract class Figure {
    abstract getArea(): number;
    abstract getPerimeter(): number;
  
    print(): void {
      console.log(`Area: ${this.getArea().toFixed(2)}, Perimeter: ${this.getPerimeter().toFixed(2)}`);
    }
  }
  
  export default Figure;
  