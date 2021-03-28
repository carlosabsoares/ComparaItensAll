import { AbstractControl, FormGroup } from '@angular/forms';

export class ValidatorField {
  static MustMatch(controlName: string, matchingControlName: string): any{
    return (group: AbstractControl) => {
      const fromGroup = group as FormGroup;
    }
  }
}
