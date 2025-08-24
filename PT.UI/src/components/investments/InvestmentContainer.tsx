import { use } from 'react';
import { InvestmentsPortal } from '../../contexts/investmentsContext';
import InvestmentCard from './InvestmentCard';

export default function InvestmentContainer() {
  const formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD',
  });

  const { investments } = use(InvestmentsPortal);

  return (
    <div className='grid md:grid-cols-4 sm:grid-cols-2 mt-10 gap-10 max-w-7xl mx-auto'>
      {(investments ?? []).map((inv) => (
        <InvestmentCard
          key={inv.name}
          title={'Investment'}
          name={inv.name}
          type={inv.assetType}
          value={formatter.format(inv.totalValue)}
        />
      ))}
    </div>
  );
}
