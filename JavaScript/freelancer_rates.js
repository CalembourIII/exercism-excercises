  // https://exercism.org/tracks/javascript/exercises/freelancer-rates

export function dayRate(ratePerHour) {
    return ratePerHour*8;
  }

export function daysInBudget(budget, ratePerHour) {
    return Math.floor(budget / dayRate(ratePerHour));

  }
export function priceWithMonthlyDiscount(ratePerHour, numDays, discount) {
    const remainingDays = numDays % 22;
    const fullMonths = Math.floor(numDays / 22);
    const fullMonthsPrice = (dayRate(ratePerHour) * 22 * fullMonths) * (1-discount);
    const remainingDaysPrice = remainingDays * dayRate(ratePerHour);
    return Math.ceil((fullMonthsPrice) + remainingDaysPrice);
  }