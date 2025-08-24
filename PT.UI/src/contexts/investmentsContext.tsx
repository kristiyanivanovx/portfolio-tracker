import React from 'react';
import type { Investment } from '../types/investment';

type InvestmentsContextType = {
  investments: Investment[];
  totalValue: number;
};

export const InvestmentsPortal = React.createContext<InvestmentsContextType>({
  investments: [],
  totalValue: 0,
});
