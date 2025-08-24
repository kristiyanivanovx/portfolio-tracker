import { use } from 'react';
import DistributionWidget from './DistributionWidget';
import InvestedValueWidget from './InvestedValueWidget';
import { InvestmentsPortal } from '../../contexts/investmentsContext';

export default function WidgetsContainer() {
  const formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
  });

  const { totalValue } = use(InvestmentsPortal);

  return (
    <div className='grid md:grid-cols-2 sm:grid-cols-1 mt-6 gap-10 max-w-7xl mx-auto'>
      <InvestedValueWidget content={formatter.format(totalValue)} />
      <DistributionWidget />
    </div>
  );
}
